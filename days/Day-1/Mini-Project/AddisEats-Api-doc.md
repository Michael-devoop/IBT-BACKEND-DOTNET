
GET    /api/v1/restaurants?area=Bole&page=1   # list, filtered and paged
GET    /api/v1/restaurants/14/menu            # that restaurant's menu
POST   /api/v1/orders                         # place an order    -> 201
PATCH  /api/v1/orders/91/status               # update the status -> 200
DELETE /api/v1/orders/91                      # cancel it         -> 204
POST   /api/v1/payments/telebirr              # start an ETB payment
POST   /api/v1/auth/login   
