import random
import time

# Calculate sum of 1,000,000
n = 1000000

# O(n)
def sum_by_loop(n):
    start = time.time()
    
    total_sum = 0
    for i in range(1, n+1):
        total_sum += i
    end = time.time()
    
    return total_sum, end-start


# O(1)
def calculate_sum(n):
    start = time.time()
    total_sum = int((n * (n + 1)) / 2)
    end = time.time()
    
    return total_sum, end-start 


print(f'Loop: %d taking %10.7f seconds.'%sum_by_loop(n))
print(f'Calculation: %d taking %10.7f seconds.'%calculate_sum(n))