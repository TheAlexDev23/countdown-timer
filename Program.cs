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
        default:
            result = "No Num Found";
            break;
    }
    return result;
}

Console.Clear();
Console.CursorVisible = false;

for(int i = 0; i <= 9; i++) {
    Console.SetCursorPosition(0, 0);
    Console.WriteLine(GetAsciiByNum(i));
    Thread.Sleep(1000);
}

Console.CursorVisible = true;