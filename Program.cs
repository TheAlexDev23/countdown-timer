if(args.Length != 1) {
    Console.WriteLine("Wrong arguments");
    return;
}

var time = args[0];

var minutes = 0;
var seconds = 0;
var hours   = 0;

AnalyzeTime();

while (seconds >= 60) {
    minutes++;
    seconds -= 60;
}

while (minutes >= 60) {
    hours++;
    minutes -= 60;
}

FormatTime();

Console.WriteLine(hours + " " + minutes +  " " + seconds);

ConfigureConsoleToStart();

//Render every seconds the timer. And substract one second each time
while (true) {
    seconds--;
    
    FormatTime();
    
    //This will be the result we would print out (the numbers not the ASCII art)
    //For example: 1:45:12 
    string timeToPrintString = ""; 

    timeToPrintString += hours.ToString();
    
    timeToPrintString += ":";
    
    timeToPrintString += minutes.ToString("00");

    timeToPrintString += ":";
    
    timeToPrintString += seconds.ToString("00");

    int count = 0;
    
    //For each number in the result string print it's ASCII art
    foreach(var t in timeToPrintString) {
        Console.CursorLeft = 8 * count + count;
        Console.CursorTop  = 0;

        string printResult = "";

        if (t != ':') {
            try {
                printResult = GetAsciiByNum(Convert.ToInt32(t.ToString()));
            } catch {
                Console.Clear();

                Console.WriteLine(t + " " + t.ToString());
                return;
            }
        } else {
            printResult = GetAsciiByNum(10);
        }

        foreach(var s in printResult) {
            if (s != '\n') {
                Console.Write(s);
            } else {
                Console.Write(s);
                Console.CursorLeft = 8 * count + count;
            }
        }

        count++;
    }

    if((hours == minutes) && (minutes == seconds) && (seconds == 0)) {
       break; 
    }

    Thread.Sleep(1000); // wait one second before starting again
}

ConfigureConsoleToEnd();


// Would set values of Seconds Minutes and Hours according to the Time value
/* The input in the time variable is in the following format:
    XhYmZs
    X => Amount of hours (because h comes after it)
    Y => amount of minutes (because m comes after it)
    Z => amount of seconds (because s comes after it)

    We can add a buffer variable that will keep reading until it finds either h, m or s.
    When it finds one of those letters it will save all the numbers since the letter and call them hours minutes or seconds (depending if the letter was h m or s)
    Then it will clear itself and continue doing the same procedure
*/
void AnalyzeTime() {
    string? secondsStr = null;
    string? minutesStr = null;
    string? hoursStr   = null;
    var buffer         = "";

    //Itereate for every letter in the time argument and set the time minutes and seconds variables
    foreach (var t in time) {
        switch(t) {
            case 's':
                secondsStr = buffer;
                buffer = "";
                break;
            case 'm':
                minutesStr = buffer;
                buffer = "";
                break;
            case 'h':
                hoursStr = buffer;
                buffer = "";
                break;
            default:
                buffer += t;
                break;
        }
    }
    
    if (secondsStr is not null) seconds = Convert.ToInt32(secondsStr);
    if (minutesStr is not null) minutes = Convert.ToInt32(minutesStr);
    if (hoursStr is not null)   hours   = Convert.ToInt32(hoursStr);
}

//If we substract seconds one at a time. At some point the minute will end and we will need to substract one minute from the minute variable.
//Something similar happens with hours. If the hour ends we need to substract one hour from the hour variable.
//This function is the one that does all this.
void FormatTime() {
    if (seconds < 0) {
        minutes--;
        seconds = 59;
    }

    if (minutes < 0) {
        hours--;
        minutes = 59;
    }

    if (hours < 0) return;
}

//Self explanatory
void ConfigureConsoleToStart() {
    Console.Clear();
    Console.CursorVisible = false;
}

//Self explanatory
void ConfigureConsoleToEnd() {
    Console.CursorVisible = true;
}

// Some hardcoded values
string GetAsciiByNum(int num) {
    string result;
    switch(num) {
        case 0:
            result = "  ████  \n";
            result+= "██    ██\n";
            result+= "██    ██\n";
            result+= "██    ██\n";
            result+= "██    ██\n";
            result+= "██    ██\n";
            result+= "  ████  \n";
            break;
        case 1:
            result = "  ███   \n";
            result+= "██ ██   \n";
            result+= "   ██   \n";
            result+= "   ██   \n";
            result+= "   ██   \n";
            result+= "   ██   \n";
            result+= "████████\n";
            break;
        case 2:
            result = " ███████\n";
            result+= "██    ██\n";
            result+= "     ██ \n";
            result+= "   ██   \n";
            result+= " ██     \n";
            result+= " ██     \n";
            result+= " ███████\n";
            break;
        case 3:
            result = " ███████\n";
            result+= "██    ██\n";
            result+= "      ██\n";
            result+= "   ███  \n";
            result+= "      ██\n";
            result+= "██    ██\n";
            result+= " ███████\n";
            break;
       
        case 4:
            result = "██    ██\n";
            result+= "██    ██\n";
            result+= "██    ██\n";
            result+= "████████\n";
            result+= "      ██\n";
            result+= "      ██\n";
            result+= "      ██\n";
            break;
        case 5:
            result = "████████\n";
            result+= "██      \n";
            result+= "██      \n";
            result+= " ██████ \n";
            result+= "      ██\n";
            result+= "      ██\n";
            result+= "████████\n";
            break;
        case 6:
            result = " ███████\n";
            result+= "██      \n";
            result+= "██      \n";
            result+= " ██████ \n";
            result+= "██    ██\n";
            result+= "██    ██\n";
            result+= " ███████\n";
            break;
        case 7:
            result = "████████\n";
            result+= "      ██\n";
            result+= "      ██\n";
            result+= "     ██ \n";
            result+= "    ██  \n";
            result+= "    ██  \n";
            result+= "    ██  \n";
            break;
        case 8:
            result = " ██████ \n";
            result+= "██    ██\n";
            result+= "██    ██\n";
            result+= " ██████ \n";
            result+= "██    ██\n";
            result+= "██    ██\n";
            result+= " ██████ \n";
            break;
        case 9:
            result = " ██████ \n";
            result+= "██    ██\n";
            result+= "██    ██\n";
            result+= " ██████ \n";
            result+= "      ██\n";
            result+= "      ██\n";
            result+= " ██████ \n";
            break;
        case 10:
            result = "   ██   \n";
            result+= "   ██   \n";
            result+= "        \n";
            result+= "        \n";
            result+= "        \n";
            result+= "   ██   \n";
            result+= "   ██   \n";
            break;
        default:
            result = "No Num Found";
            break;
    }
    return result;
}
