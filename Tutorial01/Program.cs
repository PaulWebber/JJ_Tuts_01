// See https://aka.ms/new-console-template for more information
using Tutorial01;

Animal animal = new Cow();
Animal duck = new Duck();
Animal cow = new Cow();

Animal[] animals = new Animal[] {  animal, duck, cow }; 


foreach (Animal anim in animals)
{
    anim.Talk();
    anim.Walk();
}

Bird ducksworth = new Duck();
ducksworth.Fly();


