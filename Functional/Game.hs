import Text.Printf
import System.Random

smallestNumber = 1 :: Integer
highestNumber = 100 :: Integer

nextTurn :: Integer -> Integer -> IO ()
nextTurn secretNumber guess
    | guess > secretNumber = turn secretNumber "Die Zahl war zu hoch. Rate nochmal! Die Zahl liegt zwischen %d und %d!\n"
    | guess < secretNumber = turn secretNumber "Die Zahl war zu niedrig. Rate nochmal! Die Zahl liegt zwischen %d und %d!\n"
    | otherwise = printf "Sehr gut. Du hast die richtige Zahl erraten!\n"


turn :: Integer -> String -> IO ()
turn secretNumber prompt = do
    printf prompt smallestNumber highestNumber
    input <- getLine
    let guess = read input :: Integer
    nextTurn secretNumber guess

main = do
    secretNumber <- randomRIO(smallestNumber, highestNumber) :: IO Integer
    turn secretNumber "Rate eine zahl zwischen %d und %d \n"
