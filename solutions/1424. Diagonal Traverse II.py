class Solution:
    def findDiagonalOrder(self, nums: List[List[int]]) -> List[int]:
        
        m = len(nums)
        
        hash = collections.defaultdict(list)
        
        for i in range(m):
            for j in range(len(nums[i])):
                hash[i + j].append(nums[i][j])
                
        res= []
        
        for item in hash.values():
            res += item[::-1]
            
        return res
        
            
