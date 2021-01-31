in_range :: Integer -> Integer -> Integer ->Bool
in_range min max x =
     x >= min && x <= max

fac n
    | n <=1 = 1
    | otherwise = n * fac (n-1)
