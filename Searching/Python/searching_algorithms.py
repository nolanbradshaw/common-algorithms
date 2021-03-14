
test_list = [1,2,3,4,5,6,7,8,9,10,13,16,18,22,32,35,45,48]

def linear_search(n, term):
    for i in range(len(n)):
        if n[i] == term:
            return i
        
    return None

def binary_search(n, term):
    min_index = 0
    max_index = len(n) - 1
    
    while min_index <= max_index:
        middle = (min_index + max_index) // 2
        if term == n[middle]:
            return middle
        elif term < n[middle]:
            max_index = middle - 1
        else:
            min_index = middle + 1
    return None
    

print(binary_search(test_list, 32))