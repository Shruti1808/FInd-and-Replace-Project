# Find And Replace

#### _A web application to find a word within a string input by the user and provides a replacement to that word._

#### By _**Alexandra Holcombe && Shruti Priya**_

## Description

This web application takes three inputs from the user: a string, a word to find within that string, and a replacement for that word.  The application then makes replacements of the chosen word.

## Setup/Installation Requirements

* Requires DNU, DNX, and Mono
* Clone to local machine
* Use command "dnu restore" in command prompt/shell
* Use command "dnx kestrel" to start server
* Navigate to http://localhost:5004 in web browser of choice

## Specifications
**If the user chooses a word that is not in the string, the string will not be changed.**
* Example Input: "Hello world", "phone", "bananas"
* Example Output: "Hello world"

**If the user chooses a word that exactly matches the entire string, the entire string will be replaced.**
* Example Input: "hello", "hello", "goodbye"
* Example Output: "goodbye"

**If the user chooses a word that exactly matches a word in the string, the word will be replaced.**
* Example Input: "Hello world", "world", "universe"
* Example Output: "Hello universe"

**If the user chooses a word that is in the string but is all in uppercase, the matching word in the string will be replaced.**
* Example Input: "Hello world", "HELLO", "GOODBYE"
* Example Output: "GOODBYE world"

**If the user chooses a word that is in the string and is capitalized, the matching word in the string will be replaced.**
* Example Input: "Hello world", "World", "universe"
* Example Output: "Hello universe"

## Support and contact details

Please contact Allie Holcombe at alexandra.holcombe@gmail.com or Shruti Priya at shrutipriya1808@gmail.com with any questions, concerns, or suggestions.

## Technologies Used

This web application uses:
* Nancy
* Mono
* DNVM
* C#
* Razor

### License

*This project is licensed under the MIT license.*

Copyright (c) 2017 **_Alexandra Holcombe & Shruti Priya_**
