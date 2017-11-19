#this works ony with list xl
# xl = [4, 6, '1', 3, 5, 7, 25]

# def draw_stars(arr):
#     for i in xl:
#         print '*' * i
# draw_stars(xl)

x = [4, "Tom", 1, "Michael", 5, 7, "Jimmy Smith"]


def draw_stars2(arr):
    for i in x:
        if type(i) == int:
            print "*" * i
        if type(i) == str:
            print i[0].lower() * len(i)
draw_stars2(x)
                