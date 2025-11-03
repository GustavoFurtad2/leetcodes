int addDigits(int num) {
    
    if (num > -10 && num < 10) {
        return num;
    }

    int addedDigitsNumber = 0;

    do {

        addedDigitsNumber = 0;

        while (num != 0) {

            addedDigitsNumber += num % 10;

            num /= 10;
        }
        
        num = addedDigitsNumber;
    } while (addedDigitsNumber < -9 || addedDigitsNumber > 9);

    return addedDigitsNumber;
}