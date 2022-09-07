class Solution:
    def findDiagonalOrder(self, nums: List[List[int]]) -> List[int]:
        
        m, n = len(nums), len(nums[0])
        
        hash = collections.defaultdict(list)
        
        for i in range(m):
            for j in range(len(nums[i])):
                hash[i + j].append(nums[i][j])
                
        res, flag = [], False
        
        for item in hash.values():
            if flag: res += item
            else: res += item[::-1]
            flag = not flag
            
        return res
        
