
using ExerciceChaise;



Chaise maChaise = new Chaise(10, "plastique", "noir" );
Chaise chaise2 = new Chaise();
Chaise superChaise = new Chaise(150, "or", "dorée");

List<Chaise> list = new List<Chaise>()
{
    maChaise,
    chaise2,
    superChaise,
};

//maChaise.AfficherLesInfos();
//chaise2.AfficherLesInfos();
//superChaise.AfficherLesInfos();

foreach (Chaise chaise in list)
{
    Console.WriteLine(chaise.ToString());
}

//Console.WriteLine(maChaise);