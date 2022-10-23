# The Story Keeper

## Introduction

The Story Keeper solution is a full stack ASP.net project designed to help manage items of a book store. The solution supports the following funcions,

* Viewing the list of books in the store
* Holds book details such as book title, ISBN and availability.
* Add new books to the store
* Delete books from the store
* Search books in the store
* Edit books in the store
* Login as a user to the store
* Log out of the store

As initial security measures,

* HTTPS is configured so the transfer between the client and the server is secured by `https`.
* Create, Edit and Delete operations can be performed only by a loged in user.

## Building and Running the Solution

This project is created using Visual Studio 2022. To run this project I recommend openning the solution using Visual Studio 2022. The database migrations were done using SQL Server version 15. Therefore if Visual Studio 2022 is configured to use the same SQL Server is recommended.

Once the project is open, run the application in `Debug` mode in Visual Studio 2022 to bring up the website in your default browser served from `localhost`.

### View all books

On the top navigation bar click the link `Books`.

### Search books

On the top navigation bar click the link `Search`. Type the book name or a part of it in to the input box provided and click `Search`.

### Reserve a book

On the list view (Books), find the action `Edit` for the relavant book you want to reserve and uncheck the field `Is available?`. This will generate a booking number for the reservation made.

## Asumptions

* User tacking and mapping books against users is not expected as part of this solution.
* Create, Edit, Delete operations can be done by any logged in user. User previllages are not part of this solution.
* For the same book, quantity tracking / inventory is not part of the solution. Multiples of the same books can be added as new entries.
* Each book entry in the book list can be separately reserved (even if there are multiples in the same book) and the customer requesting the booking is not tracked.

## Further Imporovements

* Functionality to track the booking against each customer can be added.
* Book inventory tracking could be added.
