# Project Name:

Pierres Sweet Treats

#### Description

This Project is to showcase "Authentication With Identity" via our good friend Pierre, with the need to register and log in before being able to make changes to the treats available.

## Contributors

* Lucas Mollerstuen

## Description

Website designed for users to create pastries, and flavors and make connections between the two which can be manipulated. There is also functionality to edit, and delete flavors and treats. This is all locked behind an authorization wall which can only be accessed through authorization.

## Technologies Used

* _C#_
* _Html_
* _CSS_
* _ASP .NET6_
* _MySQL_
* _MVC_
* _Entity Framework Core_

## Setup/Installation 

* Clone down from GitHub at:

```https://github.com/oz-mollerstuen/PierresTreats```

* Install the following Packages:

```
dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0
dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore -v 6.0.0
```

* Create file ``` appsettings.json ``` in the production directory ``` PierresSweets ``` 

* Enter the following:

```
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=[DB-NAME-HERE];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}
```
* Set both username/password

* Build Project with
```
dotnet build
```
```
dotnet ef database update
```
```
dotnet watch run
```

## Known Bugs

No Known

* If any bugs are found please email Lucas at: 

```mollerstuen.works@gmail.com```

## License

Copyright <2023> <Lucas Mollerstuen>

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

![My Remote Image](https://user-images.githubusercontent.com/115112679/213901153-a6908444-4d32-40de-87bc-38c17b758607.png)