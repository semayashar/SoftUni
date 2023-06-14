def crossroads(green_light, free_window) :
    total_cars_passed = 0
    command = input()
    cars_in_crossroads = []

    while command != "END" :
        if command == "green" :
            current_green_light = green_light
            while current_green_light > 0 and cars_in_crossroads:
car = cars_in_crossroads.pop(0)
if len(car) <= current_green_light :
    current_green_light -= len(car)
    total_cars_passed += 1
else :
    crash_index = current_green_light
    print("A crash happened!")
    print(f"{car} was hit at {car[crash_index]}.")
    return
        else:
cars_in_crossroads.append(command)

command = input()

print("Everyone is safe.")
print(f"{total_cars_passed} total cars passed the crossroads.")


green_light_duration = int(input())
free_window_duration = int(input())

crossroads(green_light_duration, free_window_duration)
