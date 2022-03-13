if(args.Length != 1) {
    Console.WriteLine("Wrong arguments");
    return;
}

// I hate to do this, but didn't find any other way :(
var hoursPreviousEqualToZero   = false;
var minutesPreviousEqualToZero = false;

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

while (true) {
    seconds--;
    
    FormatTime();

    if((hours == minutes) && (minutes == seconds) && (seconds == 0)) {
       break; 
    }

    string timeToPrintString = ""; 

    timeToPrintString += hours.ToString();
    
    timeToPrintString += ":";
    
    timeToPrintString += minutes.ToString("00");

    timeToPrintString += ":";
    
    timeToPrintString += seconds.ToString("00");

    int count = 0;
    
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

    Thread.Sleep(1000);
}

ConfigureConsoleToEnd();

/*

All the functions

*/

// Would set values of Seconds Minutes and Hours according to the Time value
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
    
    if (hours == 0)   hoursPreviousEqualToZero   = true;
    if (minutes == 0) minutesPreviousEqualToZero = true;
}

void FormatTime() {
    if (seconds < 0) {
        minutes--;
        seconds = 59;
    }

    if (minutes < 0) {
        hours--;
        minutes = 59;
    }

    if (hours < 0) {
        return;
    }

    /* Some dumb shit I did before. Didn't know what I was doing it was around 3am 
    if (hours <= 0) {
        if(!hoursPreviousEqualToZero) {
            if(minutes <= 0 && seconds <= 0) {
                return;
            } else {
                minutes = 59;
                seconds = 59;
            }
            hoursPreviousEqualToZero = true;
        }
    } else {
        hoursPreviousEqualToZero = false;
    }
    
    if (minutes <= 0) {
        if (!minutesPreviousEqualToZero) {
            hours--;
            minutes = 59;
            seconds = 59;
            minutesPreviousEqualToZero = true;
        }
    } else {
        minutesPreviousEqualToZero = false;
    }

    if (seconds <= 0) {
        if(minutes > 0) {
            minutes--;
        } else {
            if(hours > 0) {
                hours--;
                minutes = 59;
            } else {
                return;
            }
        }
        seconds = 59;
    }
    */
}

void ConfigureConsoleToStart() {
    Console.Clear();
    Console.CursorVisible = false;
}

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
