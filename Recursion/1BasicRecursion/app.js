/** @format */

function print(n) {
  if (n == 0) {
    return;
  }
  console.log(`printed ${n}`);
  print(n - 1);
}

// print(3);