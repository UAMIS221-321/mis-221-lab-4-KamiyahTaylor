//start main
int userChoice = GetUserChoice();
while(userChoice !=3){
    RouteEm(userChoice);
    userChoice = GetUserChoice();
}
//end main

static int GetUserChoice(){
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if(IsValidChoice(userChoice)){
        return int.Parse(userChoice);
    }
    else return int.Parse(Console.ReadLine());
}

static void DisplayMenu(){
    Console.Clear();
    System.Console.WriteLine("Enter 1 To Display Full Triangle.\nEnter 2 To Display Partial Triangle.\nEnter 3 To EXIT.");
} 


static bool IsValidChoice(string userChoice){
    if(userChoice=="1" || userChoice=="2" || userChoice=="3"){
        return true;
    }
    return false;
}

static void FullTriangle(){
    Random rnd = new Random();
    int i, j, k;
    int n = rnd.Next(3,9);
    for (i = 1; i <= n; i++){
        for (j = 1; j<= n - i; j++){
            System.Console.Write(" ");
        }
        for (k = 1; k <= i; k++){
            Console.Write("* ");
        }
        Console.WriteLine("");

    }
    PauseAction();
}


static void PartialTriangle(){
    int n = new Random().Next(3,10);
    for (int i = 1; i <= n; i++){
        for (int j = 1; j<= i; j++){
            if(j == 1 || j == i || i == n){
                Console.Write("* ");
            }
            else{
                int number = new Random().Next(0,2);
                if (number == 0){
                    Console.Write("* ");
                }
                else{
                    Console.Write(" ");
                }
            }
        }
        Console.WriteLine();
    }
    PauseAction();
}

static void SayInvalid(){
    System.Console.WriteLine("Invalid Entry.");
    PauseAction();
}

static void RouteEm(int menuChoice){
    if(menuChoice==1){
        FullTriangle();
    }
    else if(menuChoice==2){
        PartialTriangle();
    }
    else if (menuChoice!=3){
        SayInvalid();
    }
}

static void PauseAction(){
    System.Console.WriteLine("Press Any Key To Continue...");
    Console.ReadKey();
}

