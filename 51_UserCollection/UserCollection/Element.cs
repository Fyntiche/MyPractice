namespace _51_UserCollection.UserCollection
{
    internal class Element
    {
        public Element(string Name, string Field1, string Field2)
        {
            this.Name = Name;
            this.Field1 = Field1;
            this.Field2 = Field2;
        }

        public string Name { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
    }
}