def fibonacci(num):
    if (num == 1):
        return 0
    elif num == 2:
        return 1
    return fibonacci(num - 1) + fibonacci(num - 2)

print(fibonacci(1))
print(fibonacci(5))
print(fibonacci(8))

def GenerateFibonacciSequence(num):
    sequence = []
    for i in range(1, num + 1):
        sequence.append(fibonacci(i))
    return sequence

print(GenerateFibonacciSequence(8))