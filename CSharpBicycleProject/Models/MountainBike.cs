namespace CSharpBicycleProject;

internal abstract class MountainBike : Bicycle
{
    public override string Style { get; } = "MountainBike";
    
    protected MountainBike(IWheelInterface wheel)
        : base(wheel) { }
} // end class
