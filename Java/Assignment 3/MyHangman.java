import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.util.*;


/**
Mariska Adriaanzen
43054226
Assignment 3
*/

public class MyHangman
{
    public static int MAX_GUESSES = 7;
   	public static MyArrayListHM<String> words = new MyArrayListHM<String>();
    public static MyArrayListHM<Character> secretWord = new MyArrayListHM<Character>();
    public static MyArrayListHM<Character> guessedWord = new MyArrayListHM<Character>();
    public static int guessesLeft;

    public static void main(String[] args) {
		
		loadWords("words.txt");
		startNewGame();
		playGame();
    }

    public static void loadWords(String filename)
	{
		
		//Read file contents
		try (BufferedReader br = new BufferedReader(new FileReader(new File(filename)))) 
		{
            String line;
            while ((line = br.readLine()) != null) 
			{
                words.add(words.getSize(), line.trim());
            }
			
            System.out.println("The words: " + words);
			//Sorts words alphabetically
            words.sortList();
            System.out.println("The sorted words: " + words);
        } 
		catch (IOException e) 
		{
            System.out.println("File not found.");
		}	
	}
	
	//New Game
    public static void startNewGame() 
	{
		//Gets a random word nout of the word list
        Random random = new Random();
        String word = words.get(random.nextInt(words.getSize()));
		
		//Clears text for a new word to be guessed
        secretWord.clear();
        guessedWord.clear();
		
        int length = word.length();
		for (int i = 0; i < length; i++) 
		{
			char c = word.charAt(i);
			secretWord.add(secretWord.getSize(), c);
			guessedWord.add(guessedWord.getSize(), '_');
		}
		
        guessesLeft = MAX_GUESSES;
        System.out.println("Welcome to Hangman!");
        System.out.println("Guessed word: " + guessedWord);
        System.out.println("Guesses left: " + guessesLeft);
    }

    public static void playGame() 
	{
        Scanner scanner = new Scanner(System.in);
		
        while (guessesLeft > 0 && !isWordGuessed()) 
		{
            System.out.print("Enter a letter: ");
            char guess = scanner.next().toUpperCase().charAt(0);

            if (secretWord.contains(guess)) 
			{
				//Letter in the word
                updateGuessedWord(guess);
                System.out.println("Correct guess!");
            } 
			else 
			{
				//Letter not in the word
                guessesLeft--;
                System.out.println("Incorrect guess.");
            }

            System.out.println("Guessed word: " + guessedWord);
            System.out.println("Guesses left: " + guessesLeft);
        }

        if (isWordGuessed()) 
		{
			//Won the game
            System.out.println("Congratulations! You guessed the word: " + guessedWord);
        } 
		else 
		{
			//Lost the agme
            System.out.println("Game over! The word was: " + secretWord);
        }
    }

    public static void updateGuessedWord(char correctLetter) 
	{
        for (int i = 0; i < secretWord.getSize(); i++) 
		{
            if (secretWord.get(i) == correctLetter) 
			{
                guessedWord.remove(i);
                guessedWord.add(i, correctLetter);
            }
        }
    }

    public static boolean isWordGuessed() 
	{
        for (int i = 0; i < guessedWord.getSize(); i++) 
		{
            if (guessedWord.get(i) == '_') 
			{
                return false;
            }
        }
        return true;
    }   
	
}