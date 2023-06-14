def cups_and_bottles(cups, bottles) :
    cups = list(reversed(cups))
    wasted_water = 0

    while cups and bottles :
        current_cup = cups[0]
        current_bottle = bottles.pop()

        if current_cup <= current_bottle :
            wasted_water += current_bottle - current_cup
            cups.pop(0)
        else:
current_cup -= current_bottle
cups[0] = current_cup

if bottles :
    remaining_bottles = ' '.join(str(bottle) for bottle in reversed(bottles))
    print(f"Bottles: {remaining_bottles}")
else:
remaining_cups = ' '.join(str(cup) for cup in cups[:: - 1])
print(f"Cups: {remaining_cups}")

print(f"Wasted litters of water: {wasted_water}")


cups = list(map(int, input().split()))
bottles = list(map(int, input().split()))

cups_and_bottles(cups, bottles)
