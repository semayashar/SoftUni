def traffic_jam(limit) :
    cars_passed = 0
    command = input()

    while command != "end" :
        if command == "green" :
            cars_to_pass = min(limit, len(queue))
            for _ in range(cars_to_pass) :
                car = queue.popleft()
                print(f"{car} passed!")
                cars_passed += 1
        else:
queue.append(command)

command = input()

print(f"{cars_passed} cars passed the crossroads.")


from collections import deque

queue_limit = int(input())
queue = deque()

traffic_jam(queue_limit)
