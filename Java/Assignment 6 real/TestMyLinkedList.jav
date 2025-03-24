import java.util.Scanner;

public class TestMyLinkedList {
    public static void main(String[] args) {
        MyLinkedList<Integer> list = new MyLinkedList<>();
        Scanner scanner = new Scanner(System.in);

        System.out.println("Enter a number (a negative number to STOP): ");
        int number = scanner.nextInt();

        while (number >= 0) {
            list.append(number);
            System.out.println("Enter a number (a negative number to STOP): ");
            number = scanner.nextInt();
        }

        MyLinkedList<Integer> multipliedList = list.Multiply();

        System.out.println("Question List = " + list);
        System.out.println("Answer List = " + multipliedList);
    }
}
