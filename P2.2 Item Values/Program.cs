/*
Create a Console Project named P2_2ItemValues
Create a class named Item
Add a field of type int named goldValue
Create an Array containing three Items
Assign the value 100 to the first Item, 200 to the second and 300 to the third Item.
Print the value of each Item to the Console.
*/


Item[] items = new Item[3];     //create 3 datas spaces empty

for (var i = 0; i < items.Length; i++)
{
    items[i] = new Item();      //create objects for each of those empty spaces
}

items[0].goldValue = 100;       //I them values
items[1].goldValue = 200;
items[2].goldValue = 300;

for (var i = 0; i < items.Length; i++)
{
    Console.WriteLine(items[i].goldValue);
}



