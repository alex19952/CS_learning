// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

string[,] arr = new string[4,4];

bool right = true;
bool down = false;
bool left = false;
bool up = false;

int num = 1;

int row = 0;
int col = 0;

int rowOut = 4;
int colOut = 4;


void NextStep(){
    ++num;
    if (right) ++col;
    else if (down) ++row;
    else if (left) --col;
    else if (up) --row;
    else Console.WriteLine("NextStep error");
}


void Rotate() {
    if (right) { // поворт вниз
        right = false;
        down = true;
        --col;
    }
    else if (down) { // поворто влево
        down = false;
        left = true;
        --row;
    }
    else if (left) { // поворот вверх
        left = false;
        up = true;
        ++col;
        --rowOut;
    }
    else if (up) { // поворот вправо
        up = false;
        right = true;
        ++row;
        --colOut;
    }
    else Console.WriteLine("Rotate error");
}

int stopFlag = 0;
while(true) {
    if (col < colOut && 
        row < rowOut &&
        col > -1 &&
        row > -1
        ) {
        if (num < 10) {
            arr[row,col] = "0" + num.ToString();
        }
        else arr[row,col] = num.ToString();

        NextStep();
        stopFlag = 0;

    }
    else {

        Rotate();
        ++stopFlag;
    }
    if (stopFlag > 1) {

        break;
    }
}

foreach (var item in arr)
{
    Console.WriteLine($"{item} ");
}

