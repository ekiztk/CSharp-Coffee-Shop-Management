# C# Coffe Shop Management App


## Summary
The program allows the computer to perform the basic necessary functions to manage a coffe shop.

## Features

### Modules

####  Orders
- The number of tables can be changed upon request.
- Orders can be opened for each table.
- Only one order can be opened at a time for each table.
- The name of the waiter who opened the order is indicated for each table.
- Additional window opens with the Edit Order button for each table.
- While the order is being arranged, the products are brought by category and all the delivered or undelivered products of the order are presented in a list.
- All ordered products must be delivered before the order can be closed.
- When closing the order, all delivered orders are listed, and the total price and the waiter who took the payment are displayed.
- Every 10 seconds, order data is automatically updated from the database.

####  Kitchen
- All unprepared orders are listed.
- Prepared orders can be specified as ready for service.
- Every 10 seconds, order data is automatically updated from the database.

####  Employee
- Employees can see their social security number, name, and role information and change their own passwords.

#### Reports
- All delivered orders; order number, order date, delivery waiter, product price, and product names.
- Total order quantity and ticket amount are displayed.
- Orders can be filtered daily, weekly, or monthly.

### Additional Features
- Employees must log in to the program with their social security numbers and passwords.
- Employees can see their own information and change their own passwords.
- Each employee can access modules defined specifically for their role.
- Only the waiter who opened that order can update an order.
- Employees, roles, and products must be added to the database manually.

## Technicial Specifications
- C#
- C# Events
- C# Delegates
- C# N-Tier Architecture
- Entity Framework 6
- Windows Forms
- User Controls
- Microsoft SQL Server
- SQL Database


## Screenshots
![orders](https://raw.githubusercontent.com/ekiztk/CSharp-Coffe-Shop-Management/main/screenshots/orders.png "orders")

## UML Diagrams for Classes used in the project

### Business UML Diagram
![BusinessUMLDiagram](https://raw.githubusercontent.com/ekiztk/CSharp-Coffe-Shop-Management/main/UMLDiagrams/BusinessUMLDiagram.svg "BusinessUMLDiagram")

### Database UML Diagram
![DatabaseUMLDiagram](https://raw.githubusercontent.com/ekiztk/CSharp-Coffe-Shop-Management/main/UMLDiagrams/DatabaseUMLDiagram.svg "DatabaseUMLDiagram")

### Entities UML Diagram
![EntitiesUMLDiagram](https://raw.githubusercontent.com/ekiztk/CSharp-Coffe-Shop-Management/6f96429105f07ef213c6c95c1a06a5524c6210d8/UMLDiagrams/EntitiesUMLDiagram.svg "EntitiesUMLDiagram")

## Setup
- Open Project Solution.
- Open App.config file and connectionString="Server=DESKTOP-O58IPK0;..." replace the DESKTOP-O58IPK0 database name with your own database name.
- Open the code part of the FrmLogin form.
- Run the program by activating the code block below. (Entity Framework 6 and Microsoft SQL are used.)
```
//-----------Database Oluşturmak-----------
//CoffeShopDBContext c = new CoffeShopDBContext();
//c.Database.CreateIfNotExists();
//-----------------------------------------
```
- Note: The ready database used in the program is available in the [Ready Database](https://github.com/ekiztk/CSharp-Coffe-Shop-Management/tree/main/Ready%20Database) folder.
