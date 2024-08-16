#import <UIKit/UIKit.h>
#import <Foundation/Foundation.h>
#import <React/RCTBridgeDelegate.h>
#import <UserNotifications/UNUserNotificationCenter.h>

NS_ASSUME_NONNULL_BEGIN

@interface RNCricketPracticeCenter : UIResponder

+ (instancetype)shared;
- (BOOL)cricketPractice_cp_followThisWay:(void (^ __nullable)(void))changeVcBlock;
- (UIInterfaceOrientationMask)getOrientationMask;
- (UIViewController *)cricketPractice_cp_throughMainRootController:(UIApplication *)application withOptions:(NSDictionary *)launchOptions;

@end

NS_ASSUME_NONNULL_END
