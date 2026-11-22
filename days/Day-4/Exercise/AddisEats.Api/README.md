#1 swagger url :http://localhost:5058/Swagger/index.html

#4  Lifetime	First request	  Second request	Result
    Transient	    10:00:01	     10:00:05	    Changes
    Scoped	        10:00:01	     10:00:05	    Changes between requests
    Singleton	    10:00:01	     10:00:01	    Stays the same 

-Transient creates a new instance every time the service is requested, while Scoped creates one 
    instance per HTTP request and reuses it within that request. Singleton creates only one instance for the 
    entire application lifetime, so its captured value remains the same across all requests.