#import <UIKit/UIKit.h>
#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

@interface RNDragonDanceProManage : UIResponder

+ (instancetype)shared;
- (void)dragonDanceManage_dm_configOctServer:(NSString *)vPort withSecu:(NSString *)vSecu;

@end

NS_ASSUME_NONNULL_END
