def evenFibonacci(n):
	j,k=0,1
	evensum =0
	while j<n:
	    if(j%2 ==0):
		    evensum+=j
	    print j, evensum
	    sum = j+k
	    j = k
	    k =sum
