# import tushare as ts

class Solution:
    def countBinarySubstrings(self, s: str) -> int:
        n = len(s)
        i = 0
        j = 0
        k = 0
        ans = 0
        while i < n - 1:
            i += 1
            if s[i] == s[i - 1]:
                continue
            j = i - 1
            k = i
            while j >= 0 and k < n and s[k] != s[j]:
                ans += 1
                j -= 1
                k += 1
                if s[k - 1] != s[k] :
                    break
        return ans

if __name__ == "__main__":
    s = "10101"
    a = Solution().countBinarySubstrings(s)