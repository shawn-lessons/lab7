/* using System.Media; */

namespace Pets
{

    public class Animal
    {
        public string Species { get; set; }
        public Animal(string species)
        {
            Species = species;
        }
    }
    // declaration for Dog class

    public abstract class Pet : Animal
    {
        public Pet(string species): base(species)
        {

        }

        public abstract void PetMe();

    }
    public class Dog : Pet
    {

        // Two properties, Name and Breed
        public string Name { get; set; }
        public string Breed { get; set; }


        // This is the constructor
        public Dog(string name, string breed): base("Dog")
        {
            this.Breed = breed;
            this.Name = name;
        }
        private void HappyBark()
        {
           /*   string wavFilePath = "happy-puppy.wav";
             SoundPlayer player = new SoundPlayer(wavFilePath);
             player.PlaySync();  */
        }
        public void Fetch()
        {
            HappyBark();

        }

        public override void PetMe()
        {
           HappyBark();
        }
        // String representation is returned by this method
        public override String ToString()
        {
            return $"{this.Name} the dog";
        }


    }
}