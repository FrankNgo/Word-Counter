# Anagram

#### By Frank Ngo

## Description

A program to test if a set of words are anagrams of another word.

## Specifications

  * Check that the user can enter in a word into the first field for the word to test.
  * Check that the user can enter in words into the test field for the words to test from.
    * Check if the user entered in case sensitive characters
      * Expected Input: 'dog'
      * Expected Output: True
      * Expected Input: 'Dog'
      * Expected Output: True
    * Check if the user entered in a alphanumeric character
      * Expected Input: '3dog'
      * Expected Output: True
    * Check if the user entered in a special character
      * Expected Input: '$dog'
      * Expected Output: False
  * Check that the form proceeds and user can enter in information.

### Installing

  * Open Terminal
  * Cd to desktop or where user would like to store directory by typing in: cd Desktop
  * Copy application contents by typing in your Terminal: git clone https://github.com/FrankNgo/Address-Book.git
  * Navigate to the application directory by typing in: cd Address-Book
  * Restore the applications dependencies by typing in: dotnet restore
  * Build the application by typing in: dotnet build
  * Run and open the application by typing in: dotnet run
  * Open any browser
  * Type in the browser URL http://localhost:5000/ to access the application

### Bugs and Tests

No known bugs

## Built With

* HTML - The web framework used
* C# - The programming language used
* CSS - Style Library
* Javascript
* Asp .NET Core MVC
* [bootstrap](https://getbootstrap.com/docs/3.3/) - Style Library
* [jquery](https://jquery.com/download/) - Javascript Library


## Author and contact details

* Frank Ngo https://github.com/FrankNgo
* Contact the author at frankngomusic@gmail.com

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
