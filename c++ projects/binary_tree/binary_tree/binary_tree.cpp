#include <iostream>
#include <string>
#include <fstream>
#include <iomanip>
using namespace std;

//struct node
struct node {
    int acctNo;
    string name;
    float blance;
    node* next;
};

//linked list class
template <class T>
class linkedList {
private:
    node* list;
public:
    linkedList() { list = NULL; }

    //putting data into the linked list in an ordered way
    void push(int x, string y, float z) {
        node* newNode = new node;
        newNode->acctNo = x;
        newNode->name = y;
        newNode->blance = z;
        newNode->next = NULL;
        node* p = list; node* q = list;
        if (list == NULL)
            list = newNode;
        else
        {
            while (p != NULL && x > p->acctNo)
            {
                q = p; p = p->next;
            }
            if (p == q)
            {  //insert in front
                newNode->next = p; list = newNode;
            }
            else
            {   //insert at the rear
                newNode->next = p; q->next = newNode;
            }

        }

    }

    //function 1 -- show balance 
    void showBalance() {
        int accountNumber;
        cout << "What is your account number? ";
        cin >> accountNumber;

        node* p = list;

        while (p != NULL) {
            if (p->acctNo == accountNumber) {
                cout << p->name << " your balance is: " << p->blance;
            }
            p = p->next;
        }


        cout << endl;
    }

    //function 2 -- depsit into account
    void depositIntoAccount() {
        float amountToDeposit;
        int x = 0;
        int accountNumber;
        cout << "What is your account number? ";
        cin >> accountNumber;

        node* p = list;
        while (p != NULL) {
            if (p->acctNo == accountNumber) {
                cout << p->name << " how much do you want to deposit ? ";
                cin >> amountToDeposit;
                x = p->blance;
                x += amountToDeposit;
                p->blance = x;
            }

            p = p->next;
        }


        cout << endl;
    }

    //function 3 -- withdraw all from account 
    void withdrawFromAccount() {
        float amountToWithdraw;
        int x = 0;
        int accountNumber;
        cout << "What is your account number? ";
        cin >> accountNumber;

        node* p = list;
        while (p != NULL) {
            if (p->acctNo == accountNumber) {
                cout << p->name << " how much do you want to withdraw? ";
                cin >> amountToWithdraw;
                x = p->blance;

                if (amountToWithdraw > x) {
                    cout << "Too much ammount. Try another amount. Should be less than " << x;
                    cout << "How much do you want to withdraw? ";
                    cin >> amountToWithdraw;
                }

                x -= amountToWithdraw;
                p->blance = x;
            }

            p = p->next;
        }


        cout << endl;
    }

    //function 4 -- show me all
    void displayAll() {
        node* p = list;
        cout << endl;
        while (p->next != NULL) {
            cout << p->acctNo << "   " << p->name << "   " << p->blance << "--->" << endl;

            p = p->next;
        }
        cout << "NULL";

        cout << endl;
    }

    //function 5 -- closeAccount
    void closeMyAccount() {
        int accountNumber;
        cout << "What is the account number you want to close? ";
        cin >> accountNumber;

        node* p = list;
        node* q = list;
        while (p != NULL && p->acctNo != accountNumber) {
            q = p;
            p = p->next;
        }

        if (p == NULL) {
            cout << "Account not found " << endl;
            return;
        }
        else {
            q->next = p->next;
            delete p;

            cout << "account has been closed" << endl;
        }
    }
};

int main() {

    //setting precision to 2
    cout << fixed << showpoint << setprecision(2);

    //creating all ncessary variables for the program
    char contOrNOt = 'y';
    int menuChoice;
    int accountNumber;
    string name;
    float balance;

    //creating the linked list l 
    linkedList<node> l;
    //openeing the file 
    ifstream f("data.txt");

    //getting data from the file and putting into l
    while (f >> accountNumber >> name >> balance) {
        l.push(accountNumber, name, balance);
    }

    //closing the file
    f.close();

    //displaying the menu
    cout << "----------------MENU-------------------" << endl;
    cout << "1.   Show my balance \n";
    cout << "2.   Deposit in my account \n";
    cout << "3.   Withdraw from my account \n";
    cout << "4.   Show me all \n";
    cout << "5.   Close my account \n";

    //while contOrNot is 'y' do the following
    while (tolower(contOrNOt) == 'y') {
        cout << endl;
        //asking for the users choice
        cout << "Please enter a choice: "; cin >> menuChoice;

        //depending on thier choice, to go the right function
        switch (menuChoice) {
        case 1:
            l.showBalance();
            break;
        case 2:
            l.depositIntoAccount();
            break;
        case 3:
            l.withdrawFromAccount();
            break;
        case 4:
            l.displayAll();
            break;
        case 5:
            l.closeMyAccount();
            break;
        }
        //asking if they want to continue, if not, end the program
        cout << endl << "do you want to continue? ";
        cin >> contOrNOt;
    }
    system("pause");
    return 0;
}
