## 1. Complete API Route Table

This table shows the main API endpoints, what they do, and the HTTP status codes they can return.

| Method | Path | Purpose | Success | Failure |
|---|---|---|---|---|
| GET | `/api/v1/restaurants` | Get all restaurants | 200 | 400, 500 |
| GET | `/api/v1/restaurants/{id}` | Get one restaurant | 200 | 400, 404, 500 |
| POST | `/api/v1/restaurants` | Create a restaurant | 201 | 400, 409, 500 |
| PUT | `/api/v1/restaurants/{id}` | Update a restaurant | 200 | 400, 404, 409, 500 |
| DELETE | `/api/v1/restaurants/{id}` | Delete a restaurant | 204 | 404, 409, 500 |
| GET | `/api/v1/menu-items` | Get all menu items | 200 | 400, 500 |
| GET | `/api/v1/menu-items/{id}` | Get one menu item | 200 | 400, 404, 500 |
| POST | `/api/v1/menu-items` | Create a menu item | 201 | 400, 403, 409, 500 |
| PUT | `/api/v1/menu-items/{id}` | Update a menu item | 200 | 400, 403, 404, 409, 500 |
| DELETE | `/api/v1/menu-items/{id}` | Delete a menu item | 204 | 403, 404, 409, 500 |
| GET | `/api/v1/orders` | Get all orders | 200 | 400, 401, 403, 500 |
| GET | `/api/v1/orders/{id}` | Get one order | 200 | 401, 403, 404, 500 |
| POST | `/api/v1/orders` | Create an order | 201 | 400, 401, 409, 500 |
| PATCH | `/api/v1/orders/{id}/status` | Update order status | 200 | 400, 401, 403, 404, 409, 500 |
| POST | `/api/v1/orders/{id}/cancellation` | Cancel an order | 200 | 400, 401, 403, 404, 409, 500 |

## 2. Identify Path Segments

In REST APIs, each part of a URL has a purpose.

- **Resource:** The type of data, such as restaurants or orders.
- **Identifier:** Identifies one specific resource.
- **Filter:** Helps find specific resources.

| Example | Segment | Type |
|---|---|---|
| `/api/v1/restaurants` | `restaurants` | Resource |
| `/api/v1/restaurants/5` | `5` | Identifier |
| `/api/v1/menu-items/10` | `10` | Identifier |
| `/api/v1/orders/20` | `20` | Identifier |
| `/api/v1/orders/20/status` | `status` | Subresource |
| `?category=traditional` | `category` | Filter |

**Changes made:**

Before:

```http
GET /api/v1/menu-items/category/traditional
```

After:

```http
GET /api/v1/menu-items?category=traditional
```

I moved the category into a query parameter because it is a filter, not an identifier.

## 3. Remove Verbs from API Paths

API paths should use nouns. HTTP methods already tell us what action we want to perform.

| Original | Approach 1: Resource | Approach 2: HTTP Method | Approach 3: Subresource |
|---|---|---|---|
| `/getRestaurants` | `/restaurants` | `GET /restaurants` | `/restaurants` |
| `/createRestaurant` | `/restaurants` | `POST /restaurants` | `/restaurants` |
| `/deleteRestaurant/5` | `/restaurants/5` | `DELETE /restaurants/5` | `/restaurants/5` |
| `/updateMenuItem/5` | `/menu-items/5` | `PATCH /menu-items/5` | `/menu-items/5` |
| `/searchMenu/doro` | `/menu-items` | `GET /menu-items?search=doro` | `/menu-items/search` |

**My choice:** Approach 2, using HTTP methods with resource names.

**Reason:** It makes the API simple and clear because the URL identifies the resource while the HTTP method describes the action.

## 4. Error Catalogue

These are common errors that the AddisEats API can return.

| Error Code | Status | Message |
|---|---|---|
| VALIDATION_ERROR | 400 | The request contains invalid data. |
| INVALID_ID | 400 | The provided ID is invalid. |
| UNKNOWN_QUERY_PARAMETER | 400 | Unknown query parameter. |
| UNAUTHORIZED | 401 | Authentication is required. |
| FORBIDDEN | 403 | You do not have permission. |
| RESOURCE_NOT_FOUND | 404 | The requested resource was not found. |
| UNSUPPORTED_MEDIA_TYPE | 415 | The request format is not supported. |
| RESOURCE_CONFLICT | 409 | The requested operation conflicts with existing data. |
| BUSINESS_RULE_VIOLATION | 422 | The request violates a business rule. |
| INTERNAL_SERVER_ERROR | 500 | Something went wrong on the server. |

Example error response:

```json
{
  "status": 400,
  "code": "VALIDATION_ERROR",
  "message": "Price must be greater than zero."
}
```

## 5. HTTP Status Code Decisions

| Scenario | Status | Reason |
|---|---|---|
| Search returns no results | 200 OK | The request worked, but no matching data was found. |
| Cancel an already delivered order | 409 Conflict | A delivered order cannot be cancelled. |
| Negative ETB total | 400 Bad Request | The submitted amount is invalid. |
| Courier tries to edit a menu with a valid token | 403 Forbidden | The courier is logged in but does not have permission. |

## 6. Rewrite the Twelve Badly Designed Routes

The following are example routes showing common REST API naming mistakes.

| No. | Original Route | Improved Route | Rule Broken |
|---|---|---|---|
| 1 | `/getUsers` | `GET /users` | Used a verb |
| 2 | `/createUser` | `POST /users` | Used a verb |
| 3 | `/deleteUser/5` | `DELETE /users/5` | Used a verb |
| 4 | `/getOrderById/10` | `GET /orders/10` | Unnecessary action wording |
| 5 | `/searchProducts/shoes` | `GET /products?search=shoes` | Filter placed in path |
| 6 | `/updateProduct/4` | `PATCH /products/4` | Used a verb |
| 7 | `/getAllRestaurants` | `GET /restaurants` | Unnecessary wording |
| 8 | `/createOrder` | `POST /orders` | Used a verb |
| 9 | `/cancelOrder/5` | `POST /orders/5/cancellation` | Used a verb in the path |
| 10 | `/getMenuItems` | `GET /menu-items` | Used a verb |
| 11 | `/deleteOrder/5` | `DELETE /orders/5` | Used a verb |
| 12 | `/getUserOrders/5` | `GET /users/5/orders` | Incorrect resource relationship |

**Main lesson:** Use nouns for URLs and HTTP methods for actions.

*Note: These are examples because the original twelve routes from the class handout were not provided.*

## 7. Choose REST, GraphQL, or gRPC

### Scenario 1: Public Mobile API

**Choice: REST**

I would choose REST because it is simple and works well with mobile applications. It uses HTTP and JSON, which are supported by most development platforms.

### Scenario 2: Internal Service-to-Service Communication

**Choice: gRPC**

I would choose gRPC because it provides fast communication between backend services. It also uses Protocol Buffers, which make data exchange efficient.

### Scenario 3: Dashboard Needs Six Resources on One Screen

**Choice: GraphQL**

I would choose GraphQL because the dashboard can request six different resources in one query. It also allows the frontend to request only the data it needs.

## 8. Unknown Query Parameters

**My decision: Reject unknown query parameters.**

I prefer rejecting unknown parameters because it helps developers find spelling mistakes and incorrect filters instead of silently ignoring them.

Example of a valid request:

```http
GET /api/v1/menu-items?category=traditional
```

Example of an invalid request:

```http
GET /api/v1/menu-items?categor=traditional
```

Expected response:

```http
400 Bad Request
```

```json
{
  "status": 400,
  "code": "UNKNOWN_QUERY_PARAMETER",
  "message": "Unknown query parameter: categor."
}
```