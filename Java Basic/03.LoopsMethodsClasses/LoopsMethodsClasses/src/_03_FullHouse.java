import java.util.ArrayList;
 
 
public class _03_FullHouse {
 
        public static void main(String[] args) {
                String[] cards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K","A"};
                String[] faces = { "♠", "♥","♦","♣"};
                int fullHouseCount = 0;
                
                for (int f = 0; f <=12; f++) {	
                    for (int i = 0; i <=1; i++) {
					    for (int j = i+1; j <=2; j++) {
						    for (int k = j+1; k <=3; k++) {
							    for (int s = 0; s <= 12; s++) {
									if(s!=f){
										for(int i1=0;i1<=2;i1++){
											for (int j1 = i1+1; j1 <=3; j1++) {
												System.out.printf("%s%s%s%s%s%s%s%s%s%s",
														cards[f],faces[i],
														cards[f],faces[j],
														cards[f],faces[k],
														cards[s],faces[i1],
														cards[s],faces[j1]);
												System.out.println();
												fullHouseCount++;
											}
										}
									}
								}
							}
						}
					}
               }
                System.out.println(fullHouseCount);
        }
}
