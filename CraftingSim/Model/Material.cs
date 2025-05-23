using System;

namespace CraftingSim.Model
{
    /// <summary>
    /// Represents a Material used to craft an item
    /// Materials have an Id and a Name
    /// Materials are the same if either the Id or the Name are equal
    /// </summary>
    public class Material : IMaterial
    {
        //Id of the material
        public int Id { get; }
        //name of the material
        public string Name { get; }

        public Material(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public bool Equals(IMaterial obj)
        {
            //
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return this.Id == ((IMaterial)obj).Id;
        }
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}