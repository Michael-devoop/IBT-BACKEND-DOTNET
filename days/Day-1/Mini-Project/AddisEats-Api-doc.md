# Addis Eats API Endpoints

```
GET    /api/v1/restaurants?area=Bole&page=1       # List, filtered and paged
GET    /api/v1/restaurants/14/menu                # That restaurant's menu
POST   /api/v1/orders                             # Place an order -> 201
PATCH  /api/v1/orders/91/status                   # Update the status -> 200
DELETE /api/v1/orders/91                          # Cancel it -> 204
POST   /api/v1/payments/telebirr                  # Start an ETB payment
POST   /api/v1/auth/login                         # User login
```

````
