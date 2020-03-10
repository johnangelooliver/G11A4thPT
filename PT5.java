import java.util.Scanner;

public class PT5 {
    public static Scanner input = new Scanner(System.in);
    public static int num1, num2;

    public static void main(String[] args) {
        System.out.println("Choose Operation");
        System.out.println("[1] Addition");
        System.out.println("[2] Subtraction");
        System.out.println("[3] Multiplication");
        System.out.println("[4] Division");
        System.out.print("Choice: ");
        int choice = input.nextInt();
        switch (choice) {
            case 1:
                addition();
                break;
            case 2:
                subtraction();
                break;
            case 3:
                multiplication();
                break;
            case 4:
                division();
                break;
            default:
                System.out.println("Invalid Choice. Good Byte!");
        }
    }

    public static void addition() {
        System.out.print("Enter 1st number: ");
        num1 = input.nextInt();
        System.out.print("Enter 2nd number: ");
        num2 = input.nextInt();
        System.out.println("The result of " + num1 + " and " + num2 + " is " + performOperation(num1, num2, '+'));
    }

    public static void subtraction() {
        System.out.print("Enter 1st number: ");
        num1 = input.nextInt();
        System.out.print("Enter 2nd number: ");
        num2 = input.nextInt();
        System.out.println("The result of " + num1 + " and " + num2 + " is " + performOperation(num1, num2, '-'));
    }

    public static void multiplication() {
        System.out.print("Enter 1st number: ");
        num1 = input.nextInt();
        System.out.print("Enter 2nd number: ");
        num2 = input.nextInt();
        System.out.println("The result of " + num1 + " and " + num2 + " is " + performOperation(num1, num2, '*'));
    }

    public static void division() {
        System.out.print("Enter 1st number: ");
        num1 = input.nextInt();
        System.out.print("Enter 2nd number: ");
        num2 = input.nextInt();
        System.out.println("The result of " + num1 + " and " + num2 + " is " + performOperation(num1, num2, '/'));
    }

    public static int performOperation(int num1, int num2, char operation) {
        int result;
        switch (operation) {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num1 / num2;
                break;
            default:
                result = 0;
        }
        return result;
    }
}
