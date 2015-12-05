//
//  FrameworkObjC.h
//  FrameworkObjC
//
//  Created by matsusaki-local on 2015/12/04.
//  Copyright © 2015年 Kazutaka Matsusaki. All rights reserved.
//

#import <UIKit/UIKit.h>

//! Project version number for FrameworkObjC.
FOUNDATION_EXPORT double FrameworkObjCVersionNumber;

//! Project version string for FrameworkObjC.
FOUNDATION_EXPORT const unsigned char FrameworkObjCVersionString[];

// In this header, you should import all the public headers of your framework using statements like #import <FrameworkObjC/PublicHeader.h>


@interface FrameworkObjC : NSObject

// クラスメソッドの宣言
+ (id)initMyClass;

+ (void) start;

- (void) startPrint;

@end
