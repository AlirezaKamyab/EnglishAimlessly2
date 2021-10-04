#include <iostream>
#include <iomanip>
#include <cstdlib>
#include <string>
using namespace std;

int easy(float score, float practice);
int normal(float score, float practice);
int hard(float score, float practice);
void clearConsole(void);

struct practice_t{
    string _pd;
    int _s;
    int _r;
};

int main() {
    int score = 0;
    int practice = 0;

    int n;
    cout << "Input n to be practices for the word" << endl;
    cout << "n : ";
    cin >> n;

    practice_t* results = new practice_t[n];

    cout << "-----------------------" << endl;
    printf("Easy : 1\nNormal : 2\nHard : 3\n\n");

    for(int i = 0; i < n; i++) {
        char input;
        cout << i + 1 << " : ";
        cin >> input;

        practice_t temp;
        if(input == '1') {
            temp._pd = "Easy";
            score += 105;
            practice++;
            temp._r = easy(score, practice);
        }
        else if(input == '2') {
            temp._pd = "Normal";
            score += 80;
            practice++;
            temp._r = normal(score, practice);
        }
        else if(input == '3') {
            temp._pd = "Hard";
            score += 55;
            practice++;
            temp._r = hard(score, practice);
        }
        else {
            temp._pd = "Easy";
            score += 100;
            practice++;
            temp._r = easy(score, practice);
        }
        temp._s = score;
        results[i] = temp;
    }

    clearConsole();

    cout << "Results are ready" << endl << endl;;
    cout << left << setw(6) << "#ID" << left << setw(15) << "Difficulty" << left << setw(12) << "Score" << left << setw(12) << "Next" << left << setw(15) << "Total Time" << endl;
    cout << setfill('-') << setw(6 + 15 + 12 + 12 + 15 - 3) << " " << setfill(' ') << endl;

    int totalTime = 0;
    for(int i = 0; i < n; i++) {
        cout << left << setw(6) << i + 1 << left << setw(15) << results[i]._pd << left << setw(12) << results[i]._s << left << setw(12) << results[i]._r;
        totalTime += results[i]._r;
        cout << left << setw(15) << totalTime << endl;
    }

    delete[] results;
    return 0;
}

int easy(float score, float practice) {
    float s = score / 100;
    int p = practice;
    float addHours = (0.8 * s * s / 2) + (6 * (s)) + 5;
    return addHours;
}

int normal(float score, float practice) {
    float s = score / 100;
    int p = practice;
    float addHours = (0.95 * s * s / 3) + (3 * (s)) + 7;
    return addHours;
}

int hard(float score, float practice) {
    float s = score / 100;
    int p = practice;
    float addHours = (1 * s * s / 4) + (4 * (s)) + 10;
    return addHours;
}

void clearConsole(void) {
    if(system("cls") == 0) return;
    system("clear");
}