if(args.Length != 1) {
    Console.WriteLine("Wrong arguments");
    return;
}

var time = args[0];

var minutes = 0;
var seconds = 0;
var hours   = 0;

AnalyzeTime();
FormatTime();

Console.Clear();
Console.CursorVisible = false;

Console.WriteLine(hours + " " + minutes +  " " + seconds);

//TODO: every second change the text on the screen and subtract 1 second from the total timer
//TODO: create something capable of drawing time in the following format hh:mm:ss 
while(true) {
    
    break;
}

Console.CursorVisible = true;

// Would set values of Seconds Minutes and Hours according to the Time value
void AnalyzeTime() {
    string? secondsStr = null;
    string? minutesStr = null;
    string? hoursStr   = null;
    var buffer         = "";
    
    foreach (var t in time)
    {
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

    if (secondsStr != null) {
        seconds = Convert.ToInt32(secondsStr);
    }
    if (minutesStr != null) {
        minutes = Convert.ToInt32(minutesStr);
    }
    if (hoursStr != null) {
       hours = Convert.ToInt32(hoursStr);
    }
}

/*
 * For example:
 * 2h65m120s
 * This function would convert it to:
 * 3h2m
 */
void FormatTime() {
    while(seconds >= 60) {
        minutes++;
        seconds -= 60;
    }

    while(minutes >= 60) {
        hours++;
        minutes -= 60;
    }
}

// Some hardcoded values
string GetAsciiByNum(int num) {
    string result;
    switch(num) {
        case 0:
            result = "  ####  \n";
            result+= "##    ##\n";
            result+= "##    ##\n";
            result+= "##    ##\n";
            result+= "##    ##\n";
            result+= "##    ##\n";
            result+= "  ####  \n";
            break;
        case 1:
            result = "  ###   \n";
            result+= "## ##   \n";
            result+= "   ##   \n";
            result+= "   ##   \n";
            result+= "   ##   \n";
            result+= "   ##   \n";
            result+= "########\n";
            break;
        case 2:
            result = " #######\n";
            result+= "##    ##\n";
            result+= "     ## \n";
            result+= "   ##   \n";
            result+= " ##     \n";
            result+= " ##     \n";
            result+= " #######\n";
            break;
        case 3:
            result = " #######\n";
            result+= "##    ##\n";
            result+= "      ##\n";
            result+= "   ###  \n";
            result+= "      ##\n";
            result+= "##    ##\n";
            result+= " #######\n";
            break;
       
        case 4:
            result = "##    ##\n";
            result+= "##    ##\n";
            result+= "##    ##\n";
            result+= "######## \n";
            result+= "      ##\n";
            result+= "      ##\n";
            result+= "      ##\n";
            break;
        case 5:
            result = "########\n";
            result+= "##      \n";
            result+= "##      \n";
            result+= " ###### \n";
            result+= "      ##\n";
            result+= "      ##\n";
            result+= "########\n";
            break;
        case 6:
            result = " #######\n";
            result+= "##      \n";
            result+= "##      \n";
            result+= " ###### \n";
            result+= "##    ##\n";
            result+= "##    ##\n";
            result+= " #######\n";
            break;
        case 7:
            result = "########\n";
            result+= "      ##\n";
            result+= "      ##\n";
            result+= "     ## \n";
            result+= "    ##  \n";
            result+= "    ##  \n";
            result+= "    ##  \n";
            break;
        case 8:
            result = " ###### \n";
            result+= "##    ##\n";
            result+= "##    ##\n";
            result+= " ###### \n";
            result+= "##    ##\n";
            result+= "##    ##\n";
            result+= " ###### \n";
            break;
        case 9:
            result = " ###### \n";
            result+= "##    ##\n";
            result+= "##    ##\n";
            result+= " ###### \n";
            result+= "      ##\n";
            result+= "      ##\n";
            result+= " ###### \n";
            break;
        case 10:
            result = "   ##   \n";
            result+= "   ##   \n";
            result+= "        \n";
            result+= "        \n";
            result+= "        \n";
            result+= "   ##   \n";
            result+= "   ##   \n";
            break;
        default:
            result = "No Num Found";
            break;
    }
    return result;
}