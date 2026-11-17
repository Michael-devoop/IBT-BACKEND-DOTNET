# 1. What Is a Server?

A server is a program that listens for requests from clients and sends responses.

# 2. Selected Website

I choose **moviepire.sc**.

# 3. HTTP Requests

| No. | Method | Request path | Status | Request body |
|---|---|---|---|---|
| 1 | GET | `/3/movie/top_rated?api_key=…&language=en-US&page=1` | 200 OK | None |
| 2 | GET | `/3/tv/popular?api_key=…&language=en-US&page=1` | 200 OK | None |
| 3 | GET | `/3/movie/1368337/videos?api_key=…` | 200 OK | None |

All three requests use the **GET** method to retrieve movie or TV information. None of these requests includes a request body.

# 4. Request and Response Headers

## A. Request Headers

| Header | Value or purpose |
|---|---|
| `Referer` | Identifies the page that initiated the request: `https://moviepire.sc/`. |
| `User-Agent` | Identifies the browser and operating system. |
| `Sec-CH-UA` | Provides browser brand and version information. |
| `Sec-CH-UA-Platform` | Identifies the operating system, such as Windows. |

## B. Response Headers

| Header | Value | Purpose |
|---|---|---|
| `Access-Control-Allow-Origin` | `*` | Allows requests from any origin. |
| `Content-Type` | `application/json;charset=utf-8` | Indicates that the response is JSON. |
| `Content-Encoding` | `gzip` | Indicates that the response is compressed. |
| `Cache-Control` | `public, max-age=21345` | Allows the response to be cached for 21,345 seconds. |





#4  POST /api/restaurants/14/orders HTTP/1.1
    Host: api.restaurant.com
    Content-Type: application/json
    Authorization: Bearer my_token
    Accept: application/json

  {
    "location": "Bole",
      "items": [
      {
      "menuItemId": 7,
      "quantity": 2
      }
     ],
   "paymentMethod": "TeleBirr"
  } 

# 5. Choosing HTTP Status Codes

- **(a) 200 OK** — The request succeeded, and the restaurant list is returned.
- **(b) 201 Created** — The request succeeded and created a new order.
- **(c) 204 No Content** — The cancellation succeeded, and there is no response body.
- **(d) 400 Bad Request** — The `qty` value has the wrong type or format for the request.
- **(e) 401 Unauthorized** — The expired token is no longer valid for authentication.
- **(f) 403 Forbidden** — The courier is authenticated but is not allowed to edit a menu.
- **(g) 404 Not Found** — Order `99999` does not exist.
- **(h) 500 Internal Server Error** — An unhandled exception prevented the server from completing the request.

# 6. Public API Contract: The Movie Database (TMDB)

Based on the TMDB endpoints used above, the API contract promises:

1. `GET api.moviedb.org/3/movie/top_rated` returns a paginated list of top-rated movies.
2. `GET api.moviedb.org/3/tv/popular` returns a paginated list of popular TV shows.
3. `GET api.moviedb.org/3/movie/{movie_id}/videos` returns video information associated with the specified movie.


