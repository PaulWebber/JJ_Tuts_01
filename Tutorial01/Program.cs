// See https://aka.ms/new-console-template for more information
using Tutorial01;

Animal animal = new Animal();
Animal duck = new Duck();
Animal cow = new Cow();

Animal[] animals = new Animal[] {  animal, duck, cow }; 


foreach (Animal anim in animals)
{
    anim.Talk();
}

Duck ducksworth = new Duck();
ducksworth.Fly();