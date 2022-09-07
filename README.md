# Pierre's Sweet and Savory Treats
_By Brad Buchholz_
## Description

### _Pierre's Sweet and Savory Treats_
_Pierre is back! He wants you to create a new application to market his sweet and savory treats. This time, he would like you to build an application with user authentication and a many-to-many relationship. Here are the features he wants in the application:_

_The application should have user authentication. A user should be able to log in and log out. Only logged in users should have create, update and delete functionality. All users should be able to have read functionality._
_There should be a many-to-many relationship between Treats and Flavors. A treat can have many flavors (such as sweet, savory, spicy, or creamy) and a flavor can have many treats. For instance, the "sweet" flavor could include chocolate croissants, cheesecake, and so on._
_A user should be able to navigate to a splash page that lists all treats and flavors. Users should be able to click on an individual treat or flavor to see all the treats/flavors that belong to it._

## Technologies Used 
* C#
* dotnet
* .Net 5.0
* HTML
* CSS
* MYSQL
* Markdown   

## Setup / Installation 

1. Download and install **`dotnet 5.0`** on your computer. 
2. Clone the GitHub [repository](https://github.com/Bradbuchholz/PierresSweetSavory.Solution) onto your computer.
3. Make sure to have MySql Workbench installed on your computer.
4. Make sure to have dotnet-ef installed - this project uses **`version 5.0.1`**. I have it globally installed, but you can also install it just in this directory. 
5. Open the project in VScode or your terminal of choice. 
6. Create an `appsettings.json` file in the `PierresSweetSavory.Solution/PierresSweetSavory/` directory and add the following code, replacing anything in `square brackets` with the information it represents specific to the project database: 
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE-NAME-HERE];uid=[USER-ID-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}


```
#### Example of complete appsettings.json
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=hair_salon;uid=Myusername;pwd=MySuperStrongPassword;"
  }
}
```
7. Open MySql Workbench and login to your server.
8. From your terminal navigate to the `PierresSweetSavory` folder and run the command **`dotnet ef database update`** to create the database from migrations.
9. Next use the command **`dotnet run`** in your terminal to launch the program.
10. The site should be avaialbe at the local host listed in your terminal. 

## Known Bugs 
* Application currently has bare bones UI, could use custom styling. 
## License
_Copyright (c) Brad Buchholz_