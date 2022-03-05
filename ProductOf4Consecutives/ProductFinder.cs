namespace ProductOf4Consecutives;

public class ProductFinder {
    public string TheNumber { get; set; }

    public ProductFinder() {
        TheNumber =
            "7316717653133062491922511967442657474235534919493499698352031277450632623957831801698480186947885184385861560789112949495459501737958331952853208805511125406987471585238630507156932909632952274430435576689664895044524452316173185640309871112172238311362229893423380308135336276614282806444486645238749303589072962904915604407723907138105158593079608667017242712188399879790879227492190169972088809377665727333001053367881220235421809751254540594752243525849077116705560136048395864467063244157221553975369781797784617406495514929086256932197846862248283972241375657056057490261407972968652414535100474821663704844031998900088952434506585412275886668811642717147992444292823086346567481391912316282458617866458359124566529476545682848912883142607690042242190226710556263211111093705442175069416589604080719840385096245544436298123098787992724428490918884580156166097919133875499200524063689912560717606058861164671094050775410022569831552000559357297257163626956188267042825248360082325753042075296345";
    }

    public int BiggestProductOfFourConsecutive() {
        int highest = 0;
        for (int i = 3; i < TheNumber.Length; i++) {
            int product = Int32.Parse(TheNumber[i].ToString()) * Int32.Parse(TheNumber[i - 1].ToString()) *
                          Int32.Parse(TheNumber[i - 2].ToString()) * Int32.Parse(TheNumber[i - 3].ToString());
            if (product > highest) {
                highest = product;
            }
        }

        return highest;
    }

    public void PrintThoseFourNumbersAndTheirIndexPlease() {
        int highest = BiggestProductOfFourConsecutive();
        for (int i = 3; i < TheNumber.Length; i++) {
            int product = Int32.Parse(TheNumber[i].ToString()) * Int32.Parse(TheNumber[i - 1].ToString()) *
                          Int32.Parse(TheNumber[i - 2].ToString()) * Int32.Parse(TheNumber[i - 3].ToString());
            if (product == highest) {
                Console.WriteLine($"The four Numbers are : \n {TheNumber[i - 3]} at index {i - 3}" +
                                  $"\n {TheNumber[i - 2]} at index {i - 2}" +
                                  $"\n {TheNumber[i - 1]} at index {i - 1}" +
                                  $"\n and {TheNumber[i]} at index {i}");
                break;
            }
        }
    }

    public int FindTheBiggestProductOfXConsecutiveNumbers(int x) {
        int highest = 0;
        for (int i = x - 1; i < TheNumber.Length; i++) {
            int product = 1;
            int index = i;
            for (int j = 0; j < x; j++) {
                product *= Int32.Parse(TheNumber[index].ToString());
                index--;
            }

            if (product > highest) {
                highest = product;

            }
        }

        return highest;
    }

    public void PrintThoseXNumbersAndTheirIndexPlease(int x) {
        int highest = FindTheBiggestProductOfXConsecutiveNumbers(x);
        for (int i = x - 1; i < TheNumber.Length; i++) {
            int product = 1;
            int index = i;
            for (int j = 0; j < x; j++) {
                product *= Int32.Parse(TheNumber[index].ToString());
                index--;
            }

            if (product==highest) {
                string printout = "The group of numbers are :";
                int tempIndex = i;
                for (int j = 0; j < x; j++) {
                    printout += $"\n {TheNumber[tempIndex]} at index {tempIndex}";
                    tempIndex--;
                }
                Console.WriteLine(printout);
                break;
            }
            

        }
    }
}