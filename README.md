Certainly! Here's the modified text with "Israel E Padilla" as the author:

# Parks Lookup API

#### By: Israel E Padilla

## Description
This project is named the "Park Lookup API" and serves as an archive of national parks. It fulfills an Epicodus prompt for creating an API with ASP.NET Core. It utilizes Swashbuckle, an implementation of Swagger that documents endpoints.

## Technologies Used
- C#
- Entity Framework Core
- ASP.NET Core
- MySQL
- Postman
- Github
- Swagger
- Vs Code

## Setup/Installation Pre-reqs

1. Install the `dotnet-ef` tool by running the following command in your terminal:
  
   dotnet tool install --global dotnet-ef --version 6.0.0
   
2. Enter the command `dotnet tool install -g dotnet-script` in Terminal.
3. [Download and install the appropriate version of MySQL Workbench](https://dev.mysql.com/downloads/workbench/).
4. [Download and install Postman](https://www.postman.com/downloads/).

### Set Up and Run Project

1. Clone this repo.
2. Open the terminal and navigate to this project's production directory called "ParksLookupApi".
3. Within the production directory "ParksLookupApi", create two new files: `appsettings.json` and `appsettings.Development.json`.
4. Within `appsettings.json`, put in the following code. Make sure to replace the `uid` and `pwd` values in the MySQL database connection string with your username and password for MySQL.


{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=parks_lookup_api;uid=[YOUR_USERNAME];pwd=[YOUR_PASSWORD];"
  }
}


5. Within `appsettings.Development.json`, add the following code:


{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Trace",
      "Microsoft.AspNetCore": "Information",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  }
}


6. Create the database using the migrations in the ParkLookupApi project. Open your shell (e.g., Terminal or GitBash) to the production directory "ParksLookupApi", and run `dotnet ef database update`. You may need to run this command for each of the branches in this repo.
7. Within the production directory "ParksLookupApi", run `dotnet watch run` in the command line to start the project server and monitor it.
9. Use your program of choice to make API calls. In your API calls, use the local host domain _http://localhost:5000_.
10. Open the browser to _https://localhost:5001_/swagger to view endpoints through swagger ui. If you cannot access localhost:5001, it is likely because you have not configured a .NET developer security certificate for HTTPS.

## Endpoints and Further Exploration
Explore the API endpoints and test them in Postman or Swagger UI in a browser accessed through localhost (see step above) otherwise look below.
There is full CRUD functionality for the 'Parks' class, here are the endpoints.

### GET /api/Parks

HTTP    
Get 

URL
/api/Parks

Expected Behavior
Returns an array encompassing all Park objects in the database.

Response Status
200: Ok

Expected Response:

[
  {
    "parkId": 1,
    "name": "Yellowstone National Park",
    "location": "United States"
  },
  {
    "parkId": 2,
    "name": "Grand Canyon National Park",
    "location": "United States"
  }
]
## GET /api/Parks with optional query params

HTTP Verb
GET

URL
/api/Parks?[PARAMETER NAME]=[PARAMETER VALUE]

Optional URL Parameters
name (string) <br> climate (string) <br> location (string)

Response Status
200:OK

Example Request URL: GET /api/Parks?Location=UnitedStates&parkId=1

[
 {
    "parkId": 1,
    "name": "Yellowstone National Park",
    "location": "United States"
  }
]


Expected Behavior
Provides an array comprising Park objects from the database that align with the given parameters. You can include multiple parameters for more refined results.



## Note on CORS
CORS is a W3C standard that allows a server to relax the same-origin policy. It is not a security feature; CORS relaxes security. It allows a server to explicitly allow some cross-origin requests while rejecting others. An API is not safer by allowing CORS. For more information or to see how CORS functions, see the Microsoft documentation. The attempt to implement CORS is on the second branch to leave the first in good condition.

## Implementing CORS
"All CORS-related work was initially done on the second branch to leave the first in good condition. Though not particularly interesting, there was some fascinating documentation on the formation of CORS and how the limitations of the same-origin policy led to the global standard. I attempted to use the built-in [EnableCors] attribute, which requires a policy reference. To access this attribute, the corresponding namespaces, using System.Web.Http; and using System.Web.Http.Cors;, will be necessary. The standard CORS policy referenced in each attribute can be seen in Program.cs and is considered a widely-used policy. With some minor tweaking, it eventually built successfully."

## Known Bugs
- Please email the host or submit an issue/pull Request.

## License
MIT License

Copyright (c) Israel E Padilla 2023 
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS," WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES, OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT, OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.






