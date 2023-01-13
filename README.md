# Project NAme

#### Description

## Contributors

* Chris Loveless

## Description
<!-- This project is a simple web application for a business to keep track of Stylists and their Clients. Stylists and Clients have a one to many relationship meaning each Client only belongs to one Stylist. A Stylist can have many clients. The application allows the user to create, update, delete, and view lists of the Stylists they employ and their corresponding clients. The app also includes fields for notes about the clients. -->

## Technologies Used

* _C#_
* _Html_
* _CSS_
* _ASP .NET6_
* _MySQL_
* _MVC_
* _Entity Framework Core_

## Setup/Installation Requirements



## Database Setup

* To connect your database, create file ```appsettings.json``` in the production directory ```HairSalon```
* Fill in the file with the following code: Be sure to replace the required fields marked with ```[]``` that must contain the database name, user id, and password.
```
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=[DB-NAME-HERE];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}
```
* To include this projects data and structure, import the ```christopher_loveless.sql``` dump file into your named database.

## Known Bugs

<!-- * _On the client details page, the appointment link should route to appointment details instead it is routed back to client details_ -->
* If any bugs are found please email a brief description to: ```chriskloveless@gmail.com```

## License
Copyright (c) 2022 Chris Loveless
_[MIT](https://choosealicense.com/licenses/mit/)_