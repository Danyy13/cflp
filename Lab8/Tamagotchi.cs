public class Tamagotchi
{
    private string name;
    private int food;
    private int hungerRate;
    private bool alive;
    private char key;
    private static readonly int FOOD_ADDED = 5;
    private static readonly int FOOD_SUBTRACTED = 3;

    private static readonly int MAX_FOOD = 20;

    public Tamagotchi(string name, int initialFood, int hungerRate, char key, InputReader inputReader)
    {
        this.name = name;
        this.food = initialFood;
        this.hungerRate = hungerRate;
        this.alive = true;
        this.key = key;
        inputReader.OnKeyPressed += HandleKeyPressed;
    }

    public async Task run()
    {
        while(alive)
        {
            Console.WriteLine(this.ToString());
            await Task.Delay(hungerRate);
            food -= FOOD_SUBTRACTED;
            checkIfDies();
        }
        Console.WriteLine(this.ToString());
    }

    public void HandleKeyPressed(object sender, string input)
    {
        if(input.Contains(key.ToString()))
        {
            this.food += FOOD_ADDED;
        }
    }

    public void die()
    {
        this.alive = false;
    }

    public void checkIfDies()
    {
        if(this.food < 0 || this.food > MAX_FOOD) this.die();
    }

    public override string ToString()
    {
        if(this.alive)
        {
            return $"Tamagotchi {this.name} este sanatos si in viata. Mancare ramasa: {this.food}";          
        }  
        return $"Tamagotchi {this.name} este mort :(";
    }
}