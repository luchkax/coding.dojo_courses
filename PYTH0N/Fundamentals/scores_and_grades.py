def get_your_grade():
    import random
    for x in range(10):
        score = random.randint(60,101)
    
        if score <=100:
            if score >= 90:
                print "Score:", score,"Grade A"
            if score <= 89:
                if score >= 80:
                    print "Score:", score, "Grade B"
                if score <= 79:
                    if score >= 70:
                        print "Score:", score, "Grade C"
                    if score <= 69:
                        if score >= 60:
                            print "Score:", score, "Grade D"
get_your_grade()