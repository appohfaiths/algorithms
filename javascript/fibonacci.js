// using recursion

function fibonacci(num) {
    if (num == 1)
        return 0;
    if (num == 2)
        return 1;
    return fibonacci(num - 1) + fibonacci(num - 2);
}

function GenerateFibonacciSequence(num) {
    const sequence = [];
    for (let index = 1; index <= num; index++) {
        sequence.push(fibonacci(index))
    }
    return sequence;
}

console.log(fibonacci(1));
console.log(fibonacci(5));
console.log(fibonacci(8));

const n = 8;
const sequence = GenerateFibonacciSequence(n);
console.log(sequence.join(", "));
// sequence.forEach(element => {
//     console.log(element + "");
// });