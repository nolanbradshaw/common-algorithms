import random

list_size = 100000
min_val = 0
max_val = 1000000
n = [random.randint(min_val, max_val) for n in range(list_size)]

def bubble_sort(n):
    for i in range(len(n)):
        for j in range(len(n) - 1):
            if n[j] > n[j + 1]:
                temp = n[j + 1]
                n[j+1] = n[j] 
                n[j] = temp
    return n

def selection_sort(n):
    for i in range(len(n)):
        min_index = i
        for j in range(i+1, len(n)):
            if n[j] < n[min_index]:
                min_index = j
        
        n[i], n[min_index] = n[min_index], n[i]
    return n

def merge_sort(n):
    if len(n) == 1:
        return
    
    middle = len(n) // 2
    left = n[:middle]
    right = n[middle:]
    
    merge_sort(left)
    merge_sort(right)
    
    # Iterators for left/right.
    i = 0
    j = 0
    # Iterator for the sorted list.
    k = 0
    while i < len(left) and j < len(right):
        if left[i] < right[j]:
            n[k] = left[i]
            i += 1
        else:
            n[k] = right[j]
            j += 1
        k += 1
        
    # Add remaining values.
    while i < len(left):
        n[k] = left[i]
        i += 1
        k += 1
        
    while j < len(right):
        n[k] = right[j]
        j += 1 
        k += 1
        
merge_sort(n.copy())