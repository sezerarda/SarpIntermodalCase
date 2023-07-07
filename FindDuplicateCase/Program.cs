using FindDuplicateCase.Process;

//"FindDuplicate" adında bir metot yazın ve parametre olarak verilen bir dizi içindeki tekrar eden sayıları bulup döndürsün.

NumberArray numberArray = new NumberArray();

// Parametre olarak almasını istediğimiz için sayıları el ile dışarıdan veriyorum.
numberArray.FindDuplicate(new int[]
{
    1, 2, 3, 4, 5, 6, 7, 2, 2, 4, 2, 3, 3, 4, 4, 4, 4,
}); 