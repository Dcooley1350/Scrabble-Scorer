|Behavior|Input|Output|
|----|------|-----|
|Should take a string as a parameter and create a new word object|Param: "Scrabble"|Word object created with Scrabble masterword property|
|Should convert any capital letters into LowerCase|"Scrabble"|"scrabble"|
|Should break the string down into an character array| "Scrabble" | {'s','c','r','a','b','b','b','l','e'}|
|Should award 1 point for each instance of aeioulnrst| "Scrabble" | wordscore  +4|
|Should award 2 points for each instance of dg| "Scrabble" | wordscore + 0|
|Should award 3 points for each instance of bcmp| "Scrabble" | wordscore + 6|
|Should award 4 points for each instance of fhvwy| "Scrabble" | wordscore + 0|
|Should awrd 5 points for each instance of k| "Kitten" | wordscore + 5|
|Should award 8 points for letters jx| "Joke" | wordscore + 8|
|Should award 10 points for letters qz | "quick" | wordscore + 10|