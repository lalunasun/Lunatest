import random


def guess_number():
    number_to_guess = random.randint(1, 100)
    attempts = 0

    print("Welcome to the Number Guessing Game!")
    print("I've picked a number between 1 and 100. Can you guess it?")

    while True:
        guess = int(input("Enter your guess: "))
        attempts += 1

        if guess < number_to_guess:
            print("Too low! Try guessing higher.")
        elif guess > number_to_guess:
            print("Too high! Try guessing lower.")
        else:
            print(f"Congratulations! You've guessed the number {number_to_guess} correctly!")
            print(f"It took you {attempts} attempts.")
            break


if __name__ == "__main__":
    guess_number()
