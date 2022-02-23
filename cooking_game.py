

"""
    if "market" in command:
        clearConsole()
        print("Welcome to The Market!")
        time.sleep(2)
        print("Here, can you buy and sell things, such like food.")
        time.sleep(3)
        print("And here it is!")
        time.sleep(2)
        print("List of Market commands:")
        print("                          Sell")
        print("                          Buy")
        print("                          Exit")
        market_commands = input()
        if "exit" in market_commands:
            continue
        if "sell" in market_commands:
            if soup < 0 or soup_with_meat < 0 or bread < 0:
                print("You don't have anything to sell, redirecting back in 3 sec")
                time.sleep(3)
                continue
            elif soup > 0 or soup_with_meat > 0:
                print("You can sell only food you made.")
                time.sleep(2)
                print("Prices on foods change after time(after updates), so be in right time to get much coins!")
                time.sleep(3)
                print("You can sell ", soup, " soup.")
                if meat_achivement:
                    print("You can sell ", soup_with_meat, " soup with meatballs.")
                if bread_achivement:
                    print("You can sell ", bread, " bread.")
                time.sleep(2)
                print("If you want to sell write: name of food you want to sell.")
                sell_command = input()
                if "soup" in sell_command:
                    print("One soup could be sold for: 25 coins")
                    print(
                        "Want to sell 1 soup for current price? If not, you will be redirected back to main commands!")
                    sell_answer = input("Write yes or no...")
                    if "yes" in sell_answer:
                        print("Selling soup!")
                        soup -= 1
                        time.sleep(2)
                        print("You got 25 coins")
                        coins += 25
                elif meat_achivement:
                    if "soup with meatballs" in sell_command:
                        print("One soup with meatballs could be sold for: 30 coins")
                        print("Want to sell 1 soup with meatballs for current price?")
                        print("If not, you will be redirected back to main commands!")
                        sell_answer = input("Write yes or no...")
                        if "yes" in sell_answer:
                            print("Selling soup!")
                            soup_with_meat -= 1
                            time.sleep(2)
                            print("You got 30 coins")
                            coins += 30
                if bread_achivement:
                    if "bread" in sell_command:
                        print("One bread could be sold for: 35 coins")
                        print("Want to sell 1 bread for current price?")
                        print("If not, you will be redirected back to main commands!")
                        sell_answer = input("Write yes or no...")
                        if "yes" in sell_answer:
                            print("Selling bread!")
                            bread -= 1
                            time.sleep(2)
                            print("You got 30 coins")
                            coins += 30
        if "buy" in market_commands:
            if coins == 0:
                print("You don't have enough money! Leaving Market in 2 sec.")
                time.sleep(2)
                continue
            else:
                print("You can buy vegetables, water and much other!")
                time.sleep(2)
                print("Here is what you can buy:")
                print("Water, 20 deciliters: 10 coins")
                print("Potato, 400 grams: 5 coins")
                print("Carrots, 6 sticks: 7 coins")
                if bread_achivement:
                    print("Flour, 200 grams: 8 coins")
                    print("Oil, 12 deciliters: 10: coins")
                if meat_achivement:
                    print("Meat, 4 packages: 5 coins")
                print("Lasagna, 1: 150 coins(being rich to buy this recommended)")
                time.sleep(3)
                print("Write in commands below what you want to buy:")
                print("Water")
                print("Potato")
                print("Carrot")
                print("Lasagna")
                if bread_achivement:
                    print("Flour")
                    print("Oil")
                if meat_achivement:
                    print("Meat")
                buy_commands = input()
                if "water" in buy_commands:
                    print("Adding 20 deciliters, minus 10 coins")
                    water += 20
                    coins -= 10
                elif "potato" in buy_commands:
                    print("Adding 400 grams potatoes, minus 5 coins")
                    potato += 400
                    coins -= 5
                elif "carrot" in buy_commands:
                    print("Adding 6 carrots, minus 7 coins")
                    carrot += 6
                    coins -= 7
                if meat_achivement:
                    if "meat" in buy_commands:
                        print("Adding 4 meat packages, minus 5 coins")
                        meat_packages += 4
                        coins -= 5
                elif "lasagna" in buy_commands:
                    print("Adding 1 lasagna, minus 150 coins(JESUS!)")
                    lasagna += 1
                    coins -= 150
                if bread_achivement:
                    if "flour" in buy_commands:
                        print("Adding 200 grams flour, minus 8 coins")
                        flour += 200
                        coins -= 8
                    elif "oil" in buy_commands:
                        print("Adding 12 deciliters, minus 12 coins")
                        oil += 12
                        coins -= 12

    if "boosts" in command:
        clearConsole()
        print("\n\nBoosts!")
        print(" Currently under construction! Come back later!")
        
        print("\n List of Boosts commands:")
        print("                          List")
        print("                          Buy")
        print("                          Exit")
        boosts_commands = input()
        
        if "list" in commands:
            
        
        elif "exit" in boosts_commands:
            continue
        if coins != 0:
            if "buy" in boosts_commands:
        else
        
    elif "info" in command:
        clearConsole()
        info()



    elif "update" in command or "log" in command:
        clearConsole()
        update()


    elif "exit" in command:
        exit()


    else:
        continue
"""