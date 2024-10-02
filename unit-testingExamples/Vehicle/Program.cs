IVehicle vehicle = new Vehicle("Chevy Cobalt", "Chevrolet", 1992);
TelsaVehicle telsa = new TelsaVehicle("Elon thing", "Musky", 2024);




void Print(IVehicle vehicle) {
    Console.WriteLine($"You are driving {vehicle.Name}");
}

Print(vehicle);
Print(telsa);





