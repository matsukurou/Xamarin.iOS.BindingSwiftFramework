//
//  FrameworkObjC.m
//  FrameworkObjC
//
//  Created by matsusaki-local on 2015/12/04.
//  Copyright © 2015年 Kazutaka Matsusaki. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "FrameworkObjC.h"
#import <FrameworkSwift/FrameworkSwift-Swift.h>

@implementation FrameworkObjC

// クラスメソッドの実装、初期化処理
+ (id)initMyClass {
    
    return [[self alloc] init];
}

// インスタンスメソッドの実装
+ (void) start {
    
    [FrameworkSwift start];
    
}

- (void)startPrint {
    
    [[FrameworkSwift new] startPrint];
}

@end