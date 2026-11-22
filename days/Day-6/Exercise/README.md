## 1. Route Constraints

I added `:int` constraints to all ID routes.

For example:

`GET /restaurants/{id:int}`

I tested `/restaurants/abc` and confirmed that it returns **404 Not Found** instead of 400 because the value does not match the integer constraint.

## 2. Route Parameter Names

I changed a route parameter name so it did not match the controller method parameter.

The application still compiled, but the route value was not correctly assigned to the method parameter.

This happens because C# does not check route parameter names during compilation. ASP.NET Core handles route binding at runtime.

## 3. RestaurantQuery

I created a `RestaurantQuery` class with:

- Area
- MaxFeeEtb
- Page
- Limit

I used `[FromQuery]` in the controller to receive these values from the URL and passed the query object directly to the service.

Example:

`GET /restaurants?area=Bole&page=1&limit=10`

## 4. Multiple Areas

I added an `Areas` list to the query class.

I tested:

`GET /restaurants?areas=Bole&areas=Piassa`

The API returns restaurants from either area.

When no areas are provided, the API returns all restaurants instead of an empty result.

## 5. Ambiguous Routes

I created two routes with the same URL pattern to understand route conflicts.

When both routes matched the same request, ASP.NET Core reported an `AmbiguousMatchException`.

I fixed the problem in two ways:

1. Added route constraints to distinguish the routes.
2. Used different literal paths, such as `by-id` and `by-name`.

**Startup/runtime exception:** 
Paste the actual exception output here if your ambiguity was detected during a request rather than at startup.

## 6. ActionResult

I changed the `GetOne` method from `IActionResult` to `ActionResult<RestaurantDTO>`.

This makes the expected response type clearer and helps Swagger document the response schema.

I also captured Swagger screenshots before and after the change.

**Before:** Add Swagger screenshot here.

**After:** Add Swagger screenshot here.

## 7. OrdersController

I created an `OrdersController` with two endpoints:

| Method | Endpoint | Purpose |
|---|---|---|
| GET | `/api/v1/orders/{id:int}` | Get an order by ID |
| POST | `/api/v1/orders` | Create a new order |

When an order is created successfully, the API returns **201 Created** using `CreatedAtAction()`.

I also checked the `Location` header to confirm that it points to the newly created order.

## 8. JSON Configuration

I configured JSON serialization in `Program.cs` to:

- Use camelCase property names.
- Ignore properties with null values.
- Convert enums into readable strings.

For example, `RestaurantName` becomes `restaurantName`, and `Active` is returned as a string instead of a number.

I compared the response body before and after applying these settings.

## What I Learned

Through this exercise, I learned how to:

- Use route constraints.
- Understand route parameter binding.
- Receive query parameters using `[FromQuery]`.
- Filter and paginate API results.
- Handle ambiguous routes.
- Use `ActionResult<T>` for better API responses.
- Create resources with `CreatedAtAction()`.
- Configure JSON serialization in ASP.NET Core.
